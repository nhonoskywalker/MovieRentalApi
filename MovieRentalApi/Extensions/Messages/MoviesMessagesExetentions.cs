using MRAPP.Infrastructure.Messages.Movies;
using MRAPP.Insfrastructure.Messages.Movies;
using MRAPP.Messages.Movies;
using System;

namespace MRAPP.Extensions.Messages
{
    public static class MoviesMessagesExetentions
    {
        public static AddMovieRequest AsRequest(this AddMovieWebRequest webRequest)
        {
            var result = new AddMovieRequest
            {
                Title = webRequest.Title,
                Description = webRequest.Description,
                IsDeleted = webRequest.IsDeleted,
                IsRented = webRequest.IsRented
            };

            return result;
        }

        public static UpdateMovieRequest AsRequest(this UpdateMovieWebRequest webRequest)
        {
            var result = new UpdateMovieRequest
            {
                Id = webRequest.Id,
                Title = webRequest.Title,
                Description = webRequest.Description,
                IsDeleted = webRequest.IsDeleted,
                RentalDate = webRequest.Rentaldate,
                IsRented = webRequest.IsRented
            };

            return result;
        }

        public static DeleteMovieRequest AsRequest(this DeleteMovieWebRequest webRequest)
        {
            var result = new DeleteMovieRequest
            {
                Id = webRequest.Id,
            };

            return result;
        }

        public static GetMoviesRequest AsRequest(this GetMoviesWebRequest webRequest)
        {
            var result = new GetMoviesRequest
            {

            };

            return result;
        }

        public static GetMoviesWebResponse AsWebResponse(this GetMovieResponse response)
        {
            var result = new GetMoviesWebResponse
            { 
                Errors = response.Errors,
                IsSuccessful = response.IsSuccessful,
                Message = response.Message,
                StatusCode = response.StatusCode,
                Data = response.Data
            };

            return result;
        }


        public static GetMovieByIdRequest AsRequest(this GetMovieByIdWebRequest webRequest)
        {
            var result = new GetMovieByIdRequest
            {
                Id = webRequest.Id
            };

            return result;
        }

        public static GetMovieByIdWebResponse AsWebResponse(this GetMovieByIdResponse response)
        {
            var result = new GetMovieByIdWebResponse
            {
                Errors = response.Errors,
                IsSuccessful = response.IsSuccessful,
                Message = response.Message,
                StatusCode = response.StatusCode,
                Data = response.Data
            };

            return result;
        }

        public static AddMovieWebResponse AsWebResponse(this AddMovieResponse response)
        {
            var result = new AddMovieWebResponse
            {
                Errors = response.Errors,
                IsSuccessful = response.IsSuccessful,
                Message = response.Message,
                StatusCode = response.StatusCode,
                Data = response.Data
            };

            return result;
        }

        public static UpdateMovieWebResponse AsWebResponse(this UpdateMovieResponse response)
        {
            var result = new UpdateMovieWebResponse
            {
                Errors = response.Errors,
                IsSuccessful = response.IsSuccessful,
                Message = response.Message,
                StatusCode = response.StatusCode,
                Data = response.Data
            };

            return result;
        }

        public static DeleteMovieWebResponse AsWebResponse(this DeleteMovieResponse response)
        {
            var result = new DeleteMovieWebResponse
            {
                Errors = response.Errors,
                IsSuccessful = response.IsSuccessful,
                Message = response.Message,
                StatusCode = response.StatusCode,
                Data = response.Data
            };

            return result;
        }
    }
}
