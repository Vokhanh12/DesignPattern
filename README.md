# DesignPattern
<h2>Strategy pattern</h2>


![image](https://github.com/Vokhanh12/DesignPattern/assets/36543564/c6d2d609-7a2c-4c03-8119-5f854cfebb5f)


=> example: TeachingStrategy



![Screenshot from 2023-10-19 14-32-50](https://github.com/Vokhanh12/DesignPattern/assets/36543564/26e1e355-db25-41ca-ac56-69a6227583bb)


<h3>Memento Pattern để lưu và khôi phục trạng thái đối tượng.</h3>


```bash
// Memento
public class StateMemento
{
    public bool IsEmployeeState { get; set; }
    public bool IsMustChangePw { get; set; }
    public bool IsPasswordDisableState { get; set; }
    public bool IsQuanTriVienState { get; set; }

    public StateMemento(bool isEmployeeState, bool isMustChangePw, bool isPasswordDisableState, bool isQuanTriVienState)
    {
        IsEmployeeState = isEmployeeState;
        IsMustChangePw = isMustChangePw;
        IsPasswordDisableState = isPasswordDisableState;
        IsQuanTriVienState = isQuanTriVienState;
    }
}

// Originator
public class StateManager
{
    public bool IsEmployeeState { get; set; }
    public bool IsMustChangePw { get; set; }
    public bool IsPasswordDisableState { get; set; }
    public bool IsQuanTriVienState { get; set; }

    public StateMemento SaveState()
    {
        return new StateMemento(IsEmployeeState, IsMustChangePw, IsPasswordDisableState, IsQuanTriVienState);
    }

    public void RestoreState(StateMemento memento)
    {
        IsEmployeeState = memento.IsEmployeeState;
        IsMustChangePw = memento.IsMustChangePw;
        IsPasswordDisableState = memento.IsPasswordDisableState;
        IsQuanTriVienState = memento.IsQuanTriVienState;
    }
}

// Sử dụng
var stateManager = new StateManager
{
    IsEmployeeState = true,
    IsMustChangePw = false,
    IsPasswordDisableState = false,
    IsQuanTriVienState = true
};

// Lưu trạng thái hiện tại
StateMemento savedState = stateManager.SaveState();

// Thực hiện thay đổi
stateManager.IsEmployeeState = false;
stateManager.IsMustChangePw = true;
stateManager.IsPasswordDisableState = true;
stateManager.IsQuanTriVienState = false;

// Hoàn tác thay đổi
stateManager.RestoreState(savedState);

```

