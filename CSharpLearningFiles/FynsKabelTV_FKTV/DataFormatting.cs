using Aspose.Html;

namespace FKTV
{
    public class DataFormatting
    {
        public Pluklist? DataFormattingXML(List<string> files, int index)
        {
            // Ensure the index is within bounds of the list
            if (index < 0 || index >= files.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            using (FileStream file = File.OpenRead(files[index]))
            {
                System.Xml.Serialization.XmlSerializer xmlSerializer =
                    new System.Xml.Serialization.XmlSerializer(typeof(Pluklist));
                var plukliste = (Pluklist?)xmlSerializer.Deserialize(file);
                file.Close();
                return plukliste;
            }

        }

        public void DataFormattingCSV() { }

        public HTMLDocument? DataFormattingHTML(string Source, string pluklisteName, string pluklisteAdresse)
        {
            //from https://docs.aspose.com/html/ 
            // Create an instance of an HTML document
            using (var documentHTML = new HTMLDocument())
            {
                var nameInTemplate = "[Name]";
                var adressInTemplate = "[Adress]";

                int placeName = Source.IndexOf(nameInTemplate);
                string resultName = Source.Remove(placeName, nameInTemplate.Length).Insert(placeName, pluklisteName);

                int placeAdress = Source.IndexOf(adressInTemplate);
                string resultAdress = Source.Remove(placeAdress, adressInTemplate.Length).Insert(placeAdress, pluklisteAdresse);

                //var body = documentHTML.Body;

                //// Create a paragraph element
                //var p = (HTMLParagraphElement)documentHTML.CreateElement("p");

                //// Set a custom attribute
                //p.SetAttribute("id", "my-paragraph");

                //// Create a text node
                //var text = documentHTML.CreateTextNode("my first paragraph");

                //// Attach the text to the paragraph
                //p.AppendChild(text);

                //// Attach the paragraph to the document body
                //body.AppendChild(p);

                return documentHTML;
            }
        }
    }
}
