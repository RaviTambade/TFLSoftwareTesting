var auth=require('./login');

var credential={"email":"ravi.tambade@transflower.in", "password":"seed"};

credentials=[
    {"email":"ravi.tambade@transflower.in", "password":"seed"},
    {"email":"shubhangi.tambade@ibm.com", "password":"ibm"},
    {"email":"rahul.navale@outlook.com", "password":"outlook"},
    {"email":"jai.prakash@gmail.com", "password":"gmail"}
]

describe('login function', () => {
  it('should check valid credentials', () => {
    expect(auth.login(credential.email, credential.password)).toEqual(true);

  });
});