﻿using ChatBlazorWebApp.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChatBlazorWebApp.Client.Managers
{
    public interface IChatManager
    {
        Task<List<ApplicationUser>> GetUsersAsync();
        Task SaveMessageAsync(ChatMessage message);
        Task<List<ChatMessage>> GetConversationAsync(string contactId);
        Task<ApplicationUser> GetUserDetailsAsync(string userId);
    }
}
