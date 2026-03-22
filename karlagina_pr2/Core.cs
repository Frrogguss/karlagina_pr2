using System.Text;
using System.Threading.Tasks;

namespace karlagina_pr2
{
    public class Core
    {
        public static dynamic Exicute(dynamic first, char op, dynamic second)
        {
            dynamic result = 0;
            switch (op)
            {
                case '+':
                    result = first + second;
                    break;
                case '-':
                    result = first - second;
                    break;
                case '*':
                    result = first * second;
                    break;
                case '/':
                    result = first / second;
                    break;
                case '^':
                    result = Math.Pow(first, second);
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}
