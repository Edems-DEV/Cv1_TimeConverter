using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToCsharp
{
    class MyPrint
    {
        static public void Welcome()
        {
            string welcome = @"
       __          __  _                          
       \ \        / / | |                         
        \ \  /\  / /__| | ___ ___  _ __ ___   ___ 
         \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \
          \  /\  /  __/ | (_| (_) | | | | | |  __/
           \/  \/ \___|_|\___\___/|_| |_| |_|\___|
";
            Console.WriteLine(welcome);
        }
        static public void Welcome2()
        {
            string welcome = @"
 __          __  _                                                      
 \ \        / / | |                                                     
  \ \  /\  / /__| | ___ ___  _ __ ___   ___                             
   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \                            
    \  /\  /  __/ | (_| (_) | | | | | |  __/                            
     \/  \/ \___|_|\___\___/|_| |_| |_|\___|  
                     _        
                    | |_ ___  
                    | __/ _ \ 
                    | || (_) |
                     \__\___/ 
  _____ _                                                _            
 |_   _(_)_ __ ___   ___    ___ ___  _ ____   _____ _ __| |_ ___ _ __ 
   | | | | '_ ` _ \ / _ \  / __/ _ \| '_ \ \ / / _ \ '__| __/ _ \ '__|
   | | | | | | | | |  __/ | (_| (_) | | | \ V /  __/ |  | ||  __/ |   
   |_| |_|_| |_| |_|\___|  \___\___/|_| |_|\_/ \___|_|   \__\___|_|   
";
            Console.WriteLine(welcome);
        }
        static public void Logo()
        {
            string Logo = @" 
  _____ _                                                _            
 |_   _(_)_ __ ___   ___    ___ ___  _ ____   _____ _ __| |_ ___ _ __ 
   | | | | '_ ` _ \ / _ \  / __/ _ \| '_ \ \ / / _ \ '__| __/ _ \ '__|
   | | | | | | | | |  __/ | (_| (_) | | | \ V /  __/ |  | ||  __/ |   
   |_| |_|_| |_| |_|\___|  \___\___/|_| |_|\_/ \___|_|   \__\___|_|   
";
            Console.WriteLine(Logo);
        }
    }
}
