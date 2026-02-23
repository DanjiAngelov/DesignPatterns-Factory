const NotificationCreator = require('./NotificationCreator');
const SmsNotification = require('./SmsNotification');

class SmsNotificationCreator extends NotificationCreator {

    createNotification() {
        return new SmsNotification();
    }
}

module.exports = SmsNotificationCreator;