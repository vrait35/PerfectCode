using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IFaceRecognitionProvider
    {
        File DetecFace();
        Person RecognizePhoto(File file);
    }
}
