using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Store.Test
{
   public class FootwearServiseTest
    {
        [Fact]
        public void GetAllByQuery_WithIsbn_CallsGetAllByIsbn()
        {
            var footwearReposytoryStub = new Mock<IFootwearRepository>();
            footwearReposytoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>()))
                                  .Returns(new[] { new Footwear(1, "", "", "", "", 0m) });

            footwearReposytoryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>()))
                                  .Returns(new[] { new Footwear(2, "", "", "", "", 0m) });

            var footwearServece = new FootWServise(footwearReposytoryStub.Object);

            var actual = footwearServece.GetAllByQuery("ISBN 12345-67890");

            Assert.Collection(actual, footwear => Assert.Equal(1, footwear.Id));
        }

        [Fact]
        public void GetAllByQuery_WithAuthor_CallsGetAllByIsbn()
        {
            var footwearReposytoryStub = new Mock<IFootwearRepository>();
            footwearReposytoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>()))
                                  .Returns(new[] { new Footwear(1, "", "", "", "", 0m) });

            footwearReposytoryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>()))
                                  .Returns(new[] { new Footwear(2, "", "", "", "", 0m) });

            var footwearServece = new FootWServise(footwearReposytoryStub.Object);

            var actual = footwearServece.GetAllByQuery("2345-67890");

            Assert.Collection(actual, footwear => Assert.Equal(2, footwear.Id));
        }
    }
}
