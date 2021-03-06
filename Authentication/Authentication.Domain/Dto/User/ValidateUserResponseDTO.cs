﻿using Authentication.Common.DTO;
using System;
using System.Runtime.Serialization;

namespace Authentication.Domain.Dto.User
{
    [DataContract]
    public class ValidateUserResponseDTO : ResponseDTOBase
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SurName { get; set; }
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Token { get; set; }

        [DataMember]
        public string RefreshToken { get; set; }

        [DataMember]
        public DateTime TokenExpireDate { get; set; }

    }
}
