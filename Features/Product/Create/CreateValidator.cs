﻿using Coffee_Ecommerce.API.Shared.Models;

namespace Coffee_Ecommerce.API.Features.Product.Create
{
    public class CreateValidator
    {
        public static ApiError? CheckForErrors(CreateCommand command)
        {
            if (command.CreatorId == Guid.Empty)
                return new ApiError("Creator cannot be empty");

            if (string.IsNullOrWhiteSpace(command.Name))
                return new ApiError("Name cannot be empty");

            if (command.Name.Length > 100)
                return new ApiError("Name cannot exceed 100 characters");

            if (command.Price < 1)
                return new ApiError("Price cannot be lower than 1");

            if (string.IsNullOrWhiteSpace(command.Description))
                return new ApiError("Description cannot be empty");

            if (command.Description.Length > 255)
                return new ApiError("Name cannot exceed 255 characters");

            if (command.EstablishmentId == Guid.Empty)
                return new ApiError("Establishment cannot be empty");

            return null;
        }

        public static CreateCommand Sanitize(CreateCommand command)
        {
            return new CreateCommand
            {
                CreatorId = command.CreatorId,
                Name = command.Name.Trim(),
                Price = command.Price,
                Description = command.Description.Trim(),
                EstablishmentId = command.EstablishmentId
            };
        }
    }
}
