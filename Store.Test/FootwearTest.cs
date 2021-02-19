using System;
using Xunit;

namespace Store.Test
{
    public class FootwearTest
    {
        [Fact]
        public void IsIsbn_WithNull_RetornFalse()
        {
            bool actual = Footwear.IsIsbn(null);
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithBlankString_RetornFalse()
        {
            bool actual = Footwear.IsIsbn("    ");
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithInvalidIsbn_RetornFalse()
        {
            bool actual = Footwear.IsIsbn("IsBN 545");
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn10_RetornTrue()
        {
            bool actual = Footwear.IsIsbn("IsBn 123-456-789 0");
            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithTrashStart_RetornFalse()
        {
            bool actual = Footwear.IsIsbn("xxx IsBn 123-456-789 0 eee");
            Assert.False(actual);
        }

    }
}
