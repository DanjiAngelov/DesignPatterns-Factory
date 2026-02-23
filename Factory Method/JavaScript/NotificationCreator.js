class NotificationCreator {

    createNotification() {
        throw new Error("You must override createNotification()");
    }

    sendNotification(message) {
        const notification = this.createNotification();
        notification.send(message);
    }
}

module.exports = NotificationCreator;