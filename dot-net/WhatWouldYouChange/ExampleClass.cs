using System.IO;

namespace ExampleProgram
{
    public class ExampleClass
    {
        public string exampleText { get; set; }

        public void ExampleMethod(string exampleTextFile)
        {
            var text = "";

            try
            {
                var fs = File.Open(exampleTextFile, FileMode.Open);
                var streamReader = new StreamReader(fs);
                text = streamReader.ReadToEnd();
            }
            catch
            {
                text = text + "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis non pulvinar sapien, nec accumsan justo. Suspendisse";
                text = text + "\n";
                text = text + "facilisis auctor tortor, a maximus erat feugiat eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Proin at";
                text = text + "\n";
                text = text + "euismod nisi, egestas imperdiet turpis. Ut scelerisque diam sit amet tincidunt mollis.Curabitur eu quam ultricies,";
                text = text + "\n";
                text = text + "tincidunt augue et, lobortis diam.Suspendisse pharetra aliquet augue. Duis eu sollicitudin erat. Integer luctus";
                text = text + "\n";
                text = text + "euismod suscipit. In erat nulla, aliquet id consequat nec, luctus nec justo. In at gravida est, semper elementum nisi. ";
                text = text + "\n";
                text = text + "Phasellus interdum dapibus massa, sed volutpat odio rhoncus a. Proin pellentesque quam non justo sodales eleifend.";
                text = text + "\n";
                text = text + "Curabitur ornare arcu id mauris porta vehicula.";
                text = text + "\n";
                text = text + "\n";
                text = text + "Donec vehicula metus purus. Nulla ut augue eros. Mauris scelerisque justo nibh, non suscipit dui egestas sit amet.";
                text = text + "\n";
                text = text + "Vestibulum et magna pharetra, auctor eros sit amet, mollis neque. Vestibulum ultricies dolor diam, id semper sem";
                text = text + "\n";
                text = text + "ultricies eget. Interdum et malesuada fames ac ante ipsum primis in faucibus.Sed nec pulvinar orci. Donec sed nisl";
                text = text + "\n";
                text = text + "varius, mollis enim auctor, placerat sapien.Vivamus accumsan dui neque, eu tincidunt elit venenatis vel. Sed pharetra";
                text = text + "\n";
                text = text + "elit sed gravida convallis.";
                text = text + "\n";
                text = text + "\n";
            }

            exampleText = text;
        }
    }
}