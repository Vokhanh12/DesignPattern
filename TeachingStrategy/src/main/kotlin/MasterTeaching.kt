class MasterTeaching : ITeachingStrategy{
    override fun calculateteaching(certificate: String): String {
        return "the room is teaching with " + certificate
    }
}