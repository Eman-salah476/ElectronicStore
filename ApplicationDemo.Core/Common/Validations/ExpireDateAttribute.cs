using System.ComponentModel.DataAnnotations;

namespace ApplicationDemo.Core.Common.Validations
{
    public class ExpireDateAttribute : ValidationAttribute
    {
        //Request handler
        public override bool IsValid(object value)
        {
            var expireDate = DateTime.Parse(value.ToString());
            if (expireDate <= DateTime.Now)
                return false;
            else
                return true;
        }
    }
}
