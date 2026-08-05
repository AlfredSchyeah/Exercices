using System.Text;

string cc = "312434324";
int LastChar = cc.Length;
var sb = new StringBuilder(cc, LastChar);
for (int i = 0; i < sb.Length - 4; i++)
{
    sb[i] = '#';
}
Console.WriteLine(sb.ToString());
