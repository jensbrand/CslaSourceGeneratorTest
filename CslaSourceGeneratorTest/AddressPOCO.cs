using System.ComponentModel.DataAnnotations;
using Csla;

namespace CslaSourceGeneratorTest;

[CslaImplementProperties]
public partial class AddressPOCO : BusinessBase<AddressPOCO>
{
    [Display(Name = "Address Line 1")]
    public partial string? AddressLine1 { get; private set; }
    public partial string AddressLine2 { get; set; }
    public partial string Town { get; set; }
    public partial string County { get; set; }
    public partial string Postcode { get; set; }
    [CslaIgnoreProperty]
    public partial string IgnoredProperty { get; set; }
}

public partial class AddressPOCO
{
    public partial string IgnoredProperty { get => ""; set { } }
}