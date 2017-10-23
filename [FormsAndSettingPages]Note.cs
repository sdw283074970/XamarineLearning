//这一部分主要阐述如何从用户获得输入并读取这些输入，包括以下组件：
//1）开关（Switch）
//2）滑块（Slider）
//3）步进调整器（Stepper）
//4）条目和编辑器（Entry&Editor）
//5）选择器（Picker）
//6）日期和时间选择器（Date&TimePicker）
//7）表视图（Table View）
//8）定制单元（CustomCell）
//9）可绑定属性（BindableProperties）
//10）导航式选择器（PickerWithNavigation）

//1.开关（Switch）
//最简单的组件之一，顾名思义提供两种状态，返回值类型为bool，用户每一次点击将改变开关的真假状态，常见于各种应用。主要属性有：
//1）IsToggled="<bool>" 表示默认开关状态。true为开，false为关。
//2）Toggled="<handle_event>" 每一次值的改变将激发事件，通过handle_event返回一个bool值，可用于与其他组件联动。如：

  void partial class MainPage : ContentPage {
    void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e) {
      label.IsVisible = e.Value;
    }
  }
      
//3）也可不用event handler，用Binding Expression来绑定其他组件与开关的状态，如：

  <Switch IsToggled="true" x:Name="switch />
  <Label Text="Content"
      IsVisible="{Binding Source={x:Reference switch}, Path=IsToggled}" />

//2.滑块（Slider）
//最简单的组件之一，拖动滑块按滑块目前所占比例返回数值类型的值，范围和小数点后位数可自定义。主要属性有：
//1）Maximum=""&Minimum="" 设定范围。
//  注意：设定值范围时，先设定最大值，再设定最小值，否则程序崩溃。因为默认值范围为0-1，先设定任何大于1的最小值将导致程序崩溃。
//2）同样可试用Binding Expression将滑块的值与其他组件的值绑定在一起。如：

  <Slider x:Name="slider" />
  <Label Text="{Binding Source={x:Reference slider}, Path=Value}">

//3）在以上Binding Expression中可添加C#标准格式来限定小数位数。如：

  <Slider x:Name="slider" />
  <Label Text="{Binding Source={x:Reference slider}, Path=Value, StringFormat='{0:N0}'}"> 
  
//4）ValueChanged="handle_event" 任何改变的值将激发handle_event事件。EventArgs有两个属性，e.NewValue和e.OldValue，不作赘述。

//3.步进调整器（Stepper）
//步进调整器有与滑块相似的API，包括范围调整、默认值调整以及事件触发等，相同部分不作赘述。点击+和-来对数值进行调整。主要属性有：
//1）Increment="<Value>" 设置步进增量。
//2）与以上部分有相同的Binding Expression。如：

  <Stepper x:Name="stepper" />
  <Label Text="{Binding Source={x:Reference stepper}, Path=Value}">
  
//4.条目和编辑器（Entry&Editor）
//条目类似于表单，但其中的值可直接作为引用读取。条目的主要属性有：
//1）keyboard="<Enumeration>" 枚举属性有Chat, Default, Email, Numeric, Telephone, Text和Url。对应的枚举将限定输入类型和格式，顾名思义不作赘述。
//2）Placeholder="<String>" 在空条目状态下以灰色呈现在条目中的默认字符串，通常为举例和引导用户输入正确的类型。
//3）IsPassword="<bool>" 是否为密码类型条目。如果是，则输入值将不可见，以实心圆代替。
//4）Completed="Handle_Completed" 在完成条目后激发Handle_Completed事件。
//5）TextChanged="Handle_TextChanged" 在条目内容改变后激发Handle_TextChanged事件，EventArgs同样有NewTextValue和OldTextValue两个属性。
//当需要编辑长文本时就需要编辑器，主要需要考虑其位置及大小即可。须注意在任意布局中，编辑器默认只有一行，需自行扩展。

//5.选择器（Picker）
//选择器为用户提供一系列选择，通过先择不同的选项触发不同的事件。Picker.Items类型为IList<String>,在xaml中通常结构为：

<Picker x:Name="ContactMethods">
  <Picker.Item>
    <x:String>Option1</x:String>
    <x:String>Option2</x:String>
  <Picker.Item>
<Picker>

//常用属性有：
//1)Title="<String>" 设定该选择器显示在视图中的名称。
//2）SelectedIndexChanged="Handle_SelectedIndexChanged" 当选项改变时激发事件,可通过ContactMethods.SelectedIndex来传递信息。如：

  void partial class MainPage : ContentPage {
    void Handle_SelectedIndexChanged(object sender, Xamarin.Forms.ToggledEventArgs e) {
      var ContactMethod = ContactMethods.Items[ContactMethods.SelectedIndex];
      DisplayAlert("Selection", ContactMethod, "OK");
    }
  }
  
//3）SelectedIndex="Handle_SelectedIndex" 同上不做赘述。

//用后台(Code-Behind)实现选择器架构：

  public class ContactMethod {
    public int Id { get; set; }
    public string Name { get; set; }
  }

  void partial class MainPage : ContentPage {
    private IList<ContactMethod> _contactMethods;
    void Handle_SelectedIndexChanged(object sender, Xamarin.Forms.ToggledEventArgs e) {
      var name = ContactMethods.Items[ContactMethods.SelectedIndex];
      var contactMethod = _contactMethods.Single(cm => cm.Name == name);
      DisplayAlert("Selection", name, "OK");
    }
  }
  public MainPage() {
    InitializeComponent();

    _contactMethods = GetContactMethods();
    foreach (car method in _contactMethods) {
      picker.Items.Add(method.Name);
    }
  }

  private IList<ContactMethod> GetContactMethods() {
    new ContactMethod { Id = 1, Name = "SMS" }
      new ContactMethod { Id = 2, Name = "Email" }
  }
