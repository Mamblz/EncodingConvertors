using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CoodingLibrary
{
    public class EncodingConvertor
    {
        public string ConvertorToUtf8(string input) //Преобразование строки в Utf-8
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input)); //Проверка, что строка не пустaя
            }
            byte[] bytes = Encoding.Default.GetBytes(input); //получение байтов из строки
            return Encoding.UTF8.GetString(bytes); //Преобразование байтов в строку с нужной кодировкой
        }
        public string ConvertToAscii(string input) //Преобразование строки в Ascii
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));//Проверка, что строка не пустая
            }
            byte[] bytes = Encoding.UTF8.GetBytes(input); //Получение байтов из строки в кодировке Utf-8
            return Encoding.ASCII.GetString(bytes);//Преобразование байтов в строку с нужной кодировкой
        }
        public string ConvertFromUtf8(string input) //Преобразование строки из Utf-8
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));//Проверка, что строка не пустая
            }
            byte[] bytes = Encoding.UTF8.GetBytes(input);//Получение байтов из строки в кодировке Utf-8
            return Encoding.Default.GetString(bytes); //Преобразование байтов в строку и ее возвращение
        }
        public string ConvertFromAscii(string input) //Преобразование строки из Ascii
        {
            if (input == null)
            {  throw new ArgumentNullException(nameof(input)); }//Проверка, что строка не пустая
            byte[] bytes = Encoding.ASCII.GetBytes(input);//Получение байтов из строки в кодировке Ascii
            return Encoding.UTF8.GetString(bytes);//Преобразование байтов в строку и ее возвращение
        }
    }
}

