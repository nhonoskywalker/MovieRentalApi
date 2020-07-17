using MRAPP.Insfrastructure.Messages.Movies;
using MRAPP.Messages.Movies;

namespace MRAPP.Extensions.Messages
{
    public static class MoviesMessagesExetentions
    {
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
    }
}
