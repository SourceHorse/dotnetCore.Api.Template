﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Models;

namespace Template.Domain.Services
{
    public interface ISimpleMessageService
    {
        /// <summary>
        /// Adds a simple message
        /// </summary>
        /// <param name="simpleMessageCreate">The message</param>
        Task<SimpleMessage> AddMessage(SimpleMessageCreateRequest simpleMessageCreate);

        /// <summary>
        /// Retrieves a message
        /// </summary>
        /// <param name="id">The message id</param>
        Task<SimpleMessage> RetrieveMessage(Guid id);

        /// <summary>
        /// Updates a simple message
        /// </summary>
        /// <param name="id">The message id</param>
        /// <param name="simpleMessageUpdate">The message</param>
        Task<SimpleMessage> UpdateMessage(Guid id, SimpleMessageUpdateRequest simpleMessageUpdate);

        /// <summary>
        /// Soft deletes a message
        /// </summary>
        /// <param name="id">The message id</param>
        Task DeleteMessage(Guid id);
    }
}
