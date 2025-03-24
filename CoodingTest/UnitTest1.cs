using System;
using CoodingLibrary;
using Xunit;

namespace CoodingTest
{
    public class UnitTests
    {
        private readonly EncodingConvertor _converter; //создание закрытого поля
        public UnitTests() //Конструктор для создания поля
        {
            _converter = new EncodingConvertor();
        }

        [Fact]
        public void ConvertToUtf8Input() //Проверка метода для преобразования в Utf-8
        {
            string input = "Hello, World!"; //присвоение значения
            var result = _converter.ConvertorToUtf8(input); //Вызов метода
            Assert.Equal("Hello, World!", result); //Сопоставление результатов
        }

        [Fact]
        public void ConvertToUtf8NullInput() //Проверка метода для преобразования в Utf-8
        {
            string input = null; //присвоение нулевого значения
            Assert.Throws<ArgumentNullException>(() => _converter.ConvertorToUtf8(input)); //Вызов метода и сопоставление результатов
        }

        [Fact]
        public void ConvertFromAsciiInput() //Проверка метода для преобразования в Ascii
        {
            string input = "Hello, World!"; //присвоение значения
            var result = _converter.ConvertToAscii(input); //Вызов метода
            Assert.Equal("Hello, World!", result); //Сопоставление результатов
        }

        [Fact]
        public void ConvertFromAsciiNullInput() //Проверка метода для преобразования в Ascii
        {
            string input = null; //присвоение нулевого значения
            Assert.Throws<ArgumentNullException>(() => _converter.ConvertToAscii(input)); //Вызов метода и сопоставление результатов
        }
    }
}