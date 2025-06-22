// fetchdata.js

function fetchData() {
    return new Promise((resolve, reject) => {
      setTimeout(() => {
        resolve(JSON.stringify({
          name: "Jon Snow",
          age: 30,
          email: "jonsnow@housestark.com",
        }));
      }, 1000);
    });
  }