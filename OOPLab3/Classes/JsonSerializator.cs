using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OOPLab3.Interfaces;

namespace OOPLab3.Classes
{
    public class JsonSerializator : IJsonSerializator
    {
        public TransportList Deserialize(string json)
        {
            TransportList res = new TransportList();
            json = Regex.Replace(json, "[]['\n\t,\":]", string.Empty);
            string[] stream = json.Split('{', '}');
            foreach (string s in stream)
            {
                if (!s.Equals(""))
                {
                    Dictionary<string, string> tokens = new Dictionary<string, string>();
                    string[] token = s.Split(' ');
                    for (int i = 0; i < token.Length; i += 2)
                    {
                        tokens.Add(token[i], token[i + 1]);
                    }
                    Type type = Type.GetType(tokens["type"]);
                    Transport c = (Transport)Activator.CreateInstance(type);
                    foreach (var f in type.GetProperties())
                    {
                        if (f.PropertyType.Equals(typeof(string)))
                        {
                            f.SetValue(c, tokens[f.Name]);
                        }
                        else
                        {
                            f.SetValue(c, int.Parse(tokens[f.Name]));
                        }
                    }
                    foreach (var f in type.GetFields())
                    {
                        if (f.FieldType.Equals(typeof(string)))
                        {
                            f.SetValue(c, tokens[f.Name]);
                        }
                        else
                        {
                            f.SetValue(c, int.Parse(tokens[f.Name]));
                        }
                    }
                    res.Add(c);
                }
            }
            return res;
        }

        public string Serialize(TransportList transports)
        {
            int cnt = 0;
            string res = "[";
            foreach (Transport transp in transports)
            {
                cnt++;
                res += "\n\t{\n";
                Type type = transp.GetType();
                res += $"\t\t\"type\": \"{type.FullName}\",\n ";
                foreach (var f in type.GetFields())
                {
                    if (f.FieldType.Equals(typeof(string)))
                        res += $"\t\t\"{f.Name}\": \"{f.GetValue(transp)}\", \n";
                    else
                        res += $"\t\t\"{f.Name}\": {f.GetValue(transp)}, \n";
                }
                foreach (var f in type.GetProperties())
                {
                    if (f.PropertyType.Equals(typeof(string)))
                        res += $"\t\t\"{f.Name}\": \"{f.GetValue(transp)}\", \n";
                    else
                        res += $"\t\t\"{f.Name}\": {f.GetValue(transp)}, \n";
                }
                res = res.Remove(res.LastIndexOf(',')) + "\n";
                res += "\t},";
            }
            res = res.Remove(res.LastIndexOf(',')) + "\n";
            res += "]";
            return res;
        }
    }
}
