using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel;

namespace MusicTracker.Util
{
    public class XMLElementNotFoundException : Exception { }

    /// <summary>
    ///  Provides extension methods for XElement and related classes.
    /// </summary>
    public static class LinqXMLExtensions
    {
        /// <summary>
        ///  Attempts to convert the value of this XElement to the specified type. Note that this
        ///  method uses a string to hold the value as an intermediary step, and is therefore 
        ///  slower than an explicit cast.
        /// </summary>
        /// <typeparam name="T">The type you want the value to be converted to.</typeparam>
        /// <param name="element">An XElement instance holding a value</param>
        /// <returns></returns>
        public static T Get<T>(this XElement element)
        {
            T result;
            string value = (string)element;
            LinqXMLExtensions._assert(value);

            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter.IsValid(value))
            {
                try
                {
                    result = (T)converter.ConvertFrom(value);
                }
                catch (Exception) { throw new InvalidCastException(); }
            }
            else { throw new InvalidCastException(); }

            return result;
        }


        /// <summary>
        ///  Throws an XMLElementNotFoundException if the element does not exist, otherwise
        ///  returns the element.
        /// </summary>
        /// <param name="element">The element whose existence is to be checked.</param>
        /// <returns>XElement</returns>
        public static XElement StopIfMissing(this XElement element)
        {
            LinqXMLExtensions._assert(element);
            return element;
        }

        /// <summary>
        ///  Throws an XMLElementNotFoundException if no elements were found, otherwise
        ///  return the IEnumerable with the XElements.
        /// </summary>
        /// <param name="elements">The IEnumerable to be checked</param>
        /// <returns>IEnumerable</returns>
        public static IEnumerable<XElement> StopIfMissing(this IEnumerable<XElement> elements)
        {
            LinqXMLExtensions._assert(elements);
            return elements;
        }


        private static void _assert(object o)
        {
            if (o == null) { throw new XMLElementNotFoundException(); }
        }
    }
}
