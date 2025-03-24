using System;
using CoodingLibrary;
using Xunit;

namespace CoodingTest
{
    public class UnitTests
    {
        private readonly EncodingConvertor _converter; //�������� ��������� ����
        public UnitTests() //����������� ��� �������� ����
        {
            _converter = new EncodingConvertor();
        }

        [Fact]
        public void ConvertToUtf8Input() //�������� ������ ��� �������������� � Utf-8
        {
            string input = "Hello, World!"; //���������� ��������
            var result = _converter.ConvertorToUtf8(input); //����� ������
            Assert.Equal("Hello, World!", result); //������������� �����������
        }

        [Fact]
        public void ConvertToUtf8NullInput() //�������� ������ ��� �������������� � Utf-8
        {
            string input = null; //���������� �������� ��������
            Assert.Throws<ArgumentNullException>(() => _converter.ConvertorToUtf8(input)); //����� ������ � ������������� �����������
        }

        [Fact]
        public void ConvertFromAsciiInput() //�������� ������ ��� �������������� � Ascii
        {
            string input = "Hello, World!"; //���������� ��������
            var result = _converter.ConvertToAscii(input); //����� ������
            Assert.Equal("Hello, World!", result); //������������� �����������
        }

        [Fact]
        public void ConvertFromAsciiNullInput() //�������� ������ ��� �������������� � Ascii
        {
            string input = null; //���������� �������� ��������
            Assert.Throws<ArgumentNullException>(() => _converter.ConvertToAscii(input)); //����� ������ � ������������� �����������
        }
    }
}