﻿using System.Collections.Generic;

namespace CognitiveServices.Wrapper.Translator
{
    public class ResponseBody
    {
        /// <summary>
        /// The detectedLanguage property is only present in the result object when 
        /// language auto-detection is requested.
        /// </summary>
        /// <remarks>Optional</remarks>
        public DetectedLanguage DetectedLanguage { get; set; }

        /// <summary>
        /// An array of translation results. The size of the array matches the 
        /// number of target languages specified through the to query parameter.
        /// </summary>
        public IList<Translations> Translations { get; set; }
    }
}
