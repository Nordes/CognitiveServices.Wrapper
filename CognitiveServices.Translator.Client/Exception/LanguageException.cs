using System;
using System.Runtime.Serialization;

namespace CognitiveServices.Translator
{
    public class LanguageException : TranslatorException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageException"/> class.
        /// </summary>
        public LanguageException() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public LanguageException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public LanguageException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        protected LanguageException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}