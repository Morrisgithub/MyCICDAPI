using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptolibrary
{
    public class enkrypto
    {
        public string Encrypt(string input, int shift)
        {
            string result = "";

            foreach (char letter in input)
            {
                if (char.IsLetter(letter))
                {
                    
                    if (char.IsLower(letter))
                    {
                        
                        char shifted = (char)((letter - 'a' + shift) % 26 + 'a');
                        result += shifted;
                    }
                    
                    else if (char.IsUpper(letter))
                    {
                        char shifted = (char)((letter - 'A' + shift) % 26 + 'A');
                        result += shifted;
                    }
                }
                
                else if (char.IsDigit(letter))
                {
                    char shifted = (char)((letter - '0' + shift) % 10 + '0');
                    result += shifted;
                }
                else
                {
                    
                    result += letter;
                }

            }
            return result;
        }

        public string Decrypt(string input, int shift)
        {
            return Encrypt(input, -shift);
        }
    }
}
}
