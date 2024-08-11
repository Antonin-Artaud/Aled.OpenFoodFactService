using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Volo.Abp.Application.Dtos;

namespace Aled.OpenFoodFactService.Products.Dtos;

public class GetProductDto : EntityDto, IValidatableObject
{
    public string Code { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Code.Length is not ProductSharedConstants.ProductCodeLength)
        {
            yield return new ValidationResult("The product code must be 13 characters long", [nameof(Code)]);
        }

        if (!Code.All(char.IsDigit))
        {
            yield return new ValidationResult("The product code must contain only digits", new[] { nameof(Code) });
        }
    }
}