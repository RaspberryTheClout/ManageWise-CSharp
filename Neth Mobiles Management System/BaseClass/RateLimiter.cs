using System;
using System.Collections.Generic;

public class RateLimiter
{
    private class LoginAttempt
    {
        public int Attempts { get; set; }
        public DateTime LastAttempt { get; set; }
    }

    private readonly int _maxAttempts;
    private readonly TimeSpan _lockoutTimeSpan;
    private readonly Dictionary<string, LoginAttempt> _loginAttempts;

    public RateLimiter(int maxAttempts, TimeSpan lockoutTimeSpan)
    {
        _maxAttempts = maxAttempts;
        _lockoutTimeSpan = lockoutTimeSpan;
        _loginAttempts = new Dictionary<string, LoginAttempt>();
    }

    public bool IsLockedOut(string username)
    {
        if (_loginAttempts.ContainsKey(username))
        {
            var loginAttempt = _loginAttempts[username];
            if (loginAttempt.Attempts >= _maxAttempts &&
                DateTime.Now - loginAttempt.LastAttempt < _lockoutTimeSpan)
            {
                return true;
            }
        }
        return false;
    }

    public void RecordLoginAttempt(string username, bool success)
    {
        if (!_loginAttempts.ContainsKey(username))
        {
            _loginAttempts[username] = new LoginAttempt();
        }

        var loginAttempt = _loginAttempts[username];

        if (success)
        {
            loginAttempt.Attempts = 0;
        }
        else
        {
            loginAttempt.Attempts++;
            loginAttempt.LastAttempt = DateTime.Now;
        }
    }
}

