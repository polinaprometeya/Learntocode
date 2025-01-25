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

        public void DataFormattingHTML() { }
    }
}
