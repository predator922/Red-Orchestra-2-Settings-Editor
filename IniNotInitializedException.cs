using System;

namespace ro2_settings_editor
{
    class IniNotInitializedException : Exception
    {
        public IniNotInitializedException()
        {
        }

        public IniNotInitializedException(string message) : base(message)
        {
        }

    }
}