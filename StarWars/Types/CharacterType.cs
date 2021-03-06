﻿// Copyright 2019 Greg Eakin
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at:
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using HotChocolate.Types;
using StarWars.Models;

namespace StarWars.Types
{
    public class CharacterType
        : InterfaceType
    {
        protected override void Configure(IInterfaceTypeDescriptor descriptor)
        {
            descriptor.Description("The Character Description.");

            descriptor.Name("Character");

            descriptor.Field("id")
                .Type<NonNullType<IdType>>();

            descriptor.Field("name")
                .Type<StringType>();

            descriptor.Field("friends")
                .Type<ListType<CharacterType>>();

            descriptor.Field("appearsIn")
                .Type<ListType<EpisodeType>>();

            descriptor.Field("height")
                .Type<FloatType>()
                .Argument("unit", a => a.Type<EnumType<Unit>>());
        }
    }
}
