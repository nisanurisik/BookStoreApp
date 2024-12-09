using BookStoreApp.Utilities.Formatters;

namespace BookStoreApp.Extensions
{
    public static class IMVCBuilderExtensions
    {
        public static IMvcBuilder AddCustomCsvFormatter(this IMvcBuilder builder) =>
            builder.AddMvcOptions(config =>
            config.OutputFormatters
            .Add(new CsvOutputFormatter()));
    }
}
