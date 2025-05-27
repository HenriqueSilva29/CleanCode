using backend.Core.Entities;
using backend.Infrastructure.Data.MongoModels;
using backend.Infrastructure.Data.Mappers;
using Xunit;
using FluentAssertions;

namespace backend.Tests.Mappers
{
    public class IngredienteBaseMapperTests
    {
        [Fact]
        public void ToDomain_DeveMapearCorretamente()
        {
            // Arrange
            var document = new IngredienteBaseDocument
            {
                Id = "id123",
                Nome = "Farinha"
            };

            // Act
            var result = IngredienteBaseMapper.ToDomain(document);

            // Assert
            result.Should().NotBeNull();
            result.Id.Should().Be("id123");
            result.Nome.Should().Be("Farinha");
        }

        [Fact]
        public void ToDocument_DeveMapearCorretamente()
        {
            // Arrange
            var entity = new IngredienteBase
            {
                Id = "abc456",
                Nome = "Açúcar"
            };

            // Act
            var result = IngredienteBaseMapper.ToDocument(entity);

            // Assert
            result.Should().NotBeNull();
            result.Id.Should().Be("abc456");
            result.Nome.Should().Be("Açúcar");
        }
    }
}
