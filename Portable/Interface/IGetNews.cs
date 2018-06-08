using Portable.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Interface
{
   public interface IGetNews
    {
        Articles GetModelByIndex(int index);

        Articles GetModelById(int id);
    }
}
