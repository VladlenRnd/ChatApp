using Portable.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Interface
{
   public interface IGetNews
    {
        News GetModelByIndex(int index);

        News GetModelById(int id);
    }
}
