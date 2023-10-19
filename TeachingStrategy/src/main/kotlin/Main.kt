fun main(args: Array<String>) {

    var teacherA = Teacher("master",MasterTeaching())
    teacherA.ExcuteStrategy()

    teacherA = Teacher("doctor", DoctorTeaching())
    teacherA.ExcuteStrategy()


}