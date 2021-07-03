using System.Collections.Generic;


namespace Program
{
    class Player
    {
        public string Name { get; set; } 
        public int Points { get; private set;  }
        public List<string> ListOfCard = new List<string>();

        public int UpdatePoint(int PlusPoint)
        {
            return Points += PlusPoint;
        }

        
        
            
        
    }
        
            
        
    
    
           
}
     
      
    

