﻿using System;

using JIRC.Domain.Input;
using JIRC.Extensions;

using ServiceStack.Text;

namespace JIRC.Internal.Json.Gen
{
    internal static class VersionInputJsonGenerator
    {
        internal static JsonObject Generate(VersionInput versionInput)
        {
            if (versionInput == null)
            {
                throw new ArgumentNullException("versionInput");
            }

            var json = new JsonObject { { "name", versionInput.Name }, { "project", versionInput.ProjectKey } };

            if (versionInput.Description != null)
            {
                json.Add("description", versionInput.Description);
            }

            if (versionInput.ReleaseDate != null)
            {
                var dt = (DateTimeOffset)versionInput.ReleaseDate;
                json.Add("releaseDate", dt.ToRestString());
            }

            json.Add("released", versionInput.Released.ToString().ToLower());
            json.Add("archived", versionInput.Archived.ToString().ToLower());

            return json;
        }
    }
}
