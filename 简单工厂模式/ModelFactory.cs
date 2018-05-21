using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
  public static  class ModelFactory
    {
      public static Food CreateModel(string parm)
      {
          switch (parm)
          {
              case "Apple":
                  return new Apple();
              case "Orange":
                  return new Orange();   
              default:
                  return null;
                 
          }
      }
    }
}
