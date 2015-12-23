using Microsoft.AspNet.Razor.TagHelpers;

namespace AuthoringTagHelpers.TagHelpers
{
    /// <summary>
    /// 后缀TagHelper不是必须的，类名也可以命名为Email
    /// </summary>
    public class EmailTagHelper:TagHelper
    {
        private const string EmailDomain = "bcl.com";
        public string MailTo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            var address = MailTo + "@" + EmailDomain;
            output.Attributes["href"] = "mailto:" + address;
            output.Content.SetContent(address);
        }
    }
}
