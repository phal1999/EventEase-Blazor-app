namespace EventEase.Services
{
    public class AttendanceService
    {
        private readonly Dictionary<int, List<string>> _attendance = new();

        public void RegisterAttendance(int eventId, string userName)
        {
            if (!_attendance.ContainsKey(eventId))
            {
                _attendance[eventId] = new List<string>();
            }
            _attendance[eventId].Add(userName);
        }

        public IReadOnlyList<string> GetAttendees(int eventId)
            => _attendance.TryGetValue(eventId, out var attendees) ? attendees : new List<string>();
    }
}