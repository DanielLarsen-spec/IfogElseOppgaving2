using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfogElseOppgaving2
{
    internal class Oppgave2
    {
        public void Run()
        {
            int numb1 = 5;
            int numb2 = 5;
            
            if(numb1 != numb2)
            {
                
                Console.WriteLine(numb1 += numb2);
            
            }   
            else
            {
               
                Console.WriteLine(numb1 *= numb2);
            }


           
        }
        
        
    
    
    }
}
