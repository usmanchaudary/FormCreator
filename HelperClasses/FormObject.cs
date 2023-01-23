using Newtonsoft.Json;

namespace FormCreator.HelperClasses
{
    public class FormObject
    {
        /// <summary>
        /// if the input is required or not
        /// </summary>
        public bool IsRequired { get; set; }
        /// <summary>
        /// if the input type is file or not
        /// </summary>
        public bool IsFile { get; set; }
        /// <summary>
        /// label to show on the input tag
        /// </summary>
        public string LabelName { get; set; }
        /// <summary>
        /// placeholder for the input types
        /// </summary>
        public string Placeholder { get; set; }
        /// <summary>
        /// the type of value which the user would enter in this field
        /// </summary>
        public string ValueType { get; set; }
        /// <summary>
        /// can be Text or Number
        /// </summary>
        public string ElementType { get; set; }
        /// <summary>
        /// in case of element type if drop down provide the list of options here.
        /// </summary>
        public string Options { get; set; } = string.Empty;


        public List<string> GetOptions
        {
            get
            {
                return JsonConvert.DeserializeObject<List<string>>(value: Options);
            }
        }
    }
}
