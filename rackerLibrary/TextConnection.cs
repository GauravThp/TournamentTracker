using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rackerLibrary
{
    public class TextConnection : IDataConnection
    {       //TODO- Wire up the CreatePrize for the text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
