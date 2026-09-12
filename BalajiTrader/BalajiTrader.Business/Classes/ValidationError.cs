using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.Business.Classes
{
    /// <summary>
    /// The types of Validation errors
    /// </summary>
    public enum ValidationErrorTypes
    {
        Warning,
        Error
    }


    /// <summary>
    /// the process of this class is to support validation rules fr an abstract entity,
    /// </summary>
    public class ValidationError
    {
        #region Constructor
        /// <summary>
        /// Default parameterless constructor
        /// </summary>
        public ValidationError() { }

        /// <summary>
        /// A validation error that specifies the class where the error has occured and its severity and message
        /// </summary>
        /// <param name="property">class name where the validation error occures</param>
        /// <param name="message"> validation error message</param>
        /// <param name="type">validation error type</param>
        public ValidationError(string property, string message, ValidationErrorTypes type)
        {
            _property = property;
            _message = message;
            _type = type;

        }
        #endregion

        #region instance variables
        private string _property;
        private string _message;
        private ValidationErrorTypes _type;
        #endregion

        #region Property
        /// <summary>
        /// Gets/Sets the class name the validation error is for
        /// </summary>
        public string Property
        {
            get { return _property; }
            set { _property = value; }
        }

        /// <summary>
        /// Gets/Sets the type message of a validation error
        /// </summary>
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        /// <summary>
        /// Gets/Sets the type value of a validation error
        /// </summary>
        public ValidationErrorTypes Types
        {
            get { return _type; }
            set { _type = value; }
        }
        #endregion
    }

    public class ValidationErrors : List<ValidationError>
    {
        public string GetMessageByProperty(string property)
        {
            string message = string.Empty;
            foreach (ValidationError e in this)
            {
                if (e.Property == property)
                {
                    message = e.Message;
                }
            }
            return message;
        }

    }
}
