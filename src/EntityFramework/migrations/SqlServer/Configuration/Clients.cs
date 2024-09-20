/*
 Copyright (c) 2024, Martijn van Put - https://github.com/mvput/ 

 Copyright (c) 2024 HigginsSoft, Alexander Higgins - https://github.com/alexhiggins732/ 

 Copyright (c) 2018, Brock Allen & Dominick Baier. All rights reserved.

 Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information. 
 Source code and license this software can be found 

 The above copyright notice and this permission notice shall be included in all
 copies or substantial portions of the Software.
*/

using IdentityServer.Models;
using System.Collections.Generic;

namespace IdentityServerHost.Configuration;

public static class Clients
{
    public static IEnumerable<Client> Get()
    {
        var clients = new List<Client>();
        
        clients.AddRange(ClientsConsole.Get());
        clients.AddRange(ClientsWeb.Get());

        return clients;
    }
}
