using System;

namespace Sautom.Backend.Domain.Entities
{
    public class ClientFile : IEntity
    {
        private byte[] _fileData { get; set; }

        public byte[] GetContent() => _fileData;

	    public string FileName { get; set; }
	    public string FileExtension { get; set; }

	    public virtual Client Client { get; set; }
	    public Guid Id { get; set; }
    }
}
