using Newtonsoft.Json;

namespace ZoomNet.Models
{
	/// <summary>
	/// Metrics of a meeting participant.
	/// </summary>
	public class DashboardMeetingParticipant : DashboardParticipant
	{
		/// <summary>
		/// Gets or sets the type of camera used by participant during the meeting.
		/// </summary>
		/// <value>
		/// The type of camera used by participant during the meeting.
		/// </value>
		[JsonProperty(PropertyName = "camera")]
		public string Camera { get; set; }

		/// <summary>
		/// Gets or sets the number of participants who joined via Zoom Room.
		/// </summary>
		/// <value>
		/// The number of participants who joined via Zoom Room.
		/// </value>
		[JsonProperty(PropertyName = "in_room_participants")]
		public int InRoomParticipants { get; set; }

		/// <summary>
		/// Gets or sets the participant's universally unique ID (UUID).
		/// </summary>
		/// <remarks>
		/// If the participant joins the meeting by logging into Zoom, this value is the id value in the Get a user API response.
		/// If the participant joins the meeting without logging into Zoom, this returns an empty string value.
		/// </remarks>
		[JsonProperty(PropertyName = "participant_user_id")]
		public string ParticipantUserId { get; set; }

		/// <summary>
		/// Gets or sets the participant's status.
		/// </summary>
		[JsonProperty(PropertyName = "status")]
		public string Status { get; set; }
	}
}
