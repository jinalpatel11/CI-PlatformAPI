
namespace CIPlatform_Helper
{

    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Custom Exception Handler
    /// </summary>
    public class ExtendedException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedException"/> class.
        /// </summary>
        public ExtendedException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedException" /> class.
        /// </summary>
        /// <param name="code">The code.</param>
        public ExtendedException(int code)
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ExtendedException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedException" /> class.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="message">The message that describes the error.</param>
        public ExtendedException(int code, string message)
            : base(message)
        {
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a default reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public ExtendedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        protected ExtendedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public int Code { get; set; }
    }
}


