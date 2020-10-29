using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Api.Controllers
{
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private ActionResult _result;

        protected async Task<ActionResult> ExecuteAsync(Action action)
        {
            return await Task.Run(() =>
            {
                try
                {
                    action?.Invoke();
                    Success();
                }
                catch (Exception ex) { Error(ex); }
                return _result;
            });
        }

        protected async Task<ActionResult<TResult>> ExecuteAsync<TResult>(Func<TResult> action)
        {
            return await Task.Run(() =>
            {
                try
                {
                    var result = action.Invoke();
                    Success(result);
                }
                catch (Exception ex) { Error(ex); }
                return _result;
            });
        }

        protected async Task<ActionResult<TResult>> Execute<TResult>(Func<Task<TResult>> action)
        {
            try
            {
                var result = await action.Invoke();
                Success(result);
            }
            catch (Exception ex) { Error(ex); }
            return await Task.FromResult(_result);
        }

        protected void Success(object value = null) => _result = value is null ? (ActionResult)Ok() : Ok(value);

        protected void Error(Exception ex)
        {
            var model = new ModelStateDictionary();
            model.AddModelError("Error", ex.Message);
            _result = BadRequest(model);
        }
    }
}
