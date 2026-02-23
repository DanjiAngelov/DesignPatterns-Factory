const EmailNotification = require('./EmailNotification');
const SmsNotification = require('./SmsNotification');
const PushNotification = require('./PushNotification');

class NotificationFactory {

    static createNotification(type) {

        switch (type.toLowerCase()) {
            case "email":
                return new EmailNotification();
            case "sms":
                return new SmsNotification();
            case "push":
                return new PushNotification();
            default:
                throw new Error("Invalid notification type");
        }
    }
}

module.exports = NotificationFactory;