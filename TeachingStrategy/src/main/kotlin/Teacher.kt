class Teacher(
              private var _certificate : String, private var _teachingStrategy : ITeachingStrategy) {

    var teachingStrategy : ITeachingStrategy
        get() = _teachingStrategy
        set(value) {
            _teachingStrategy = value
        }


    var certificate : String
        get() = _certificate
        set(value) {
            _certificate = value
        }

    fun ExcuteStrategy(){

        println(_teachingStrategy.calculateteaching(_certificate))

    }


}