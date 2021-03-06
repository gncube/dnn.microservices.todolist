﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace TodoList.API.Client.Models
{
    public partial class TodoItem
    {
        private bool? _complete;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public bool? Complete
        {
            get { return this._complete; }
            set { this._complete = value; }
        }
        
        private string _createdAt;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }
        
        private bool? _deleted;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public bool? Deleted
        {
            get { return this._deleted; }
            set { this._deleted = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _text;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }
        
        private string _updatedAt;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the TodoItem class.
        /// </summary>
        public TodoItem()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken completeValue = inputObject["Complete"];
                if (completeValue != null && completeValue.Type != JTokenType.Null)
                {
                    this.Complete = ((bool)completeValue);
                }
                JToken createdAtValue = inputObject["CreatedAt"];
                if (createdAtValue != null && createdAtValue.Type != JTokenType.Null)
                {
                    this.CreatedAt = ((string)createdAtValue);
                }
                JToken deletedValue = inputObject["Deleted"];
                if (deletedValue != null && deletedValue.Type != JTokenType.Null)
                {
                    this.Deleted = ((bool)deletedValue);
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((string)idValue);
                }
                JToken textValue = inputObject["Text"];
                if (textValue != null && textValue.Type != JTokenType.Null)
                {
                    this.Text = ((string)textValue);
                }
                JToken updatedAtValue = inputObject["UpdatedAt"];
                if (updatedAtValue != null && updatedAtValue.Type != JTokenType.Null)
                {
                    this.UpdatedAt = ((string)updatedAtValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type TodoItem
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Complete != null)
            {
                outputObject["Complete"] = this.Complete.Value;
            }
            if (this.CreatedAt != null)
            {
                outputObject["CreatedAt"] = this.CreatedAt;
            }
            if (this.Deleted != null)
            {
                outputObject["Deleted"] = this.Deleted.Value;
            }
            if (this.Id != null)
            {
                outputObject["Id"] = this.Id;
            }
            if (this.Text != null)
            {
                outputObject["Text"] = this.Text;
            }
            if (this.UpdatedAt != null)
            {
                outputObject["UpdatedAt"] = this.UpdatedAt;
            }
            return outputObject;
        }
    }
}
