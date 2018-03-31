using System;
using System.Collections.Generic;
using System.Text;

namespace TextFormatting
{
    public interface IFormatter<T>
    {
        string Format(T input);
    }
}
