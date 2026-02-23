const NotificationFactory = require('./NotificationFactory');

const notification = NotificationFactory.createNotification("email");
notification.send("Hello from Simple Factory (JS)!");