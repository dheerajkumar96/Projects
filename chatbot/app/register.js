const AWS = require('aws-sdk');

const docclient = new AWS.DynamoDB.DocumentClient();

exports.handler = (event,context,callback) => {
    var params = {
        TableName:'RegistrationTable',
        Item:{
            'id' : Math.floor((Math.random() * 100) + 1),
            'firstname' : event.firstname,
            'lastname' : event.lastname,
            'email' : event.email,
            'username' : event.username,
            'password': event.password
        }
    };
    docclient.put(params,function(err,data)
    {
        if(err){
            callback(err,null);
        } else
       callback(null,"success");
    });
};
